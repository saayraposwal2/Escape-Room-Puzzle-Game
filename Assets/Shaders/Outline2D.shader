Shader "Custom/Outline2D"
{
    Properties
    {
        _MainTex("Sprite Texture", 2D) = "white" {}
        _OutlineColor("Outline Color", Color) = (1,1,1,1)
        _OutlineThickness("Outline Thickness", Float) = 1
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" }
        LOD 100

        Pass
        {
            ZWrite Off
            Blend SrcAlpha OneMinusSrcAlpha
            Cull Off

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 texcoord : TEXCOORD0;
            };

            struct v2f
            {
                float4 vertex : SV_POSITION;
                float2 texcoord : TEXCOORD0;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float4 _OutlineColor;
            float _OutlineThickness;

            v2f vert(appdata_t v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.texcoord = TRANSFORM_TEX(v.texcoord, _MainTex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                fixed4 c = tex2D(_MainTex, i.texcoord);
                fixed alpha = c.a;

                // Simple glow effect: mix outline color at edges
                float outline = smoothstep(0.01, 0.1, alpha);
                return lerp(_OutlineColor, c, outline);
            }
            ENDCG
        }
    }
}
