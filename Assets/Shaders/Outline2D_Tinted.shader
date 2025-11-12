Shader "Custom/Outline2D_Tinted"
{
    Properties
    {
        _MainTex("Sprite Texture", 2D) = "white" {}
        _OutlineColor("Outline Color", Color) = (1,1,1,1)
        _OutlineThickness("Outline Thickness", Range(0.0, 5.0)) = 1.0
    }

    SubShader
    {
        Tags
        {
            "Queue" = "Transparent"
            "IgnoreProjector" = "True"
            "RenderType" = "Transparent"
            "PreviewType" = "Plane"
            "CanUseSpriteAtlas" = "True"
        }

        Cull Off
        Lighting Off
        ZWrite Off
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
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
            float4 _MainTex_TexelSize;
            float4 _OutlineColor;
            float _OutlineThickness;

            v2f vert(appdata_t v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.texcoord = v.texcoord;
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                fixed4 c = tex2D(_MainTex, i.texcoord);
                if (c.a == 0)
                {
                    // Check surrounding pixels for edge
                    float2 offsets[8] = {
                        float2(-1, 0), float2(1, 0),
                        float2(0, -1), float2(0, 1),
                        float2(-1, -1), float2(-1, 1),
                        float2(1, -1), float2(1, 1)
                    };

                    for (int j = 0; j < 8; j++)
                    {
                        float2 sampleUV = i.texcoord + offsets[j] * _MainTex_TexelSize.xy * _OutlineThickness;
                        fixed4 sampleColor = tex2D(_MainTex, sampleUV);
                        if (sampleColor.a > 0.1)
                            return _OutlineColor;
                    }

                    discard;
                }

                return c;
            }
            ENDCG
        }
    }
}
