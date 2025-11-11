using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

    

    public class NotebookContents : MonoBehaviour
{
        public static String Content1 = "\n<sprite name=\"glyphs-transparent_3\">  <sprite name=\"glyphs-transparent_19\">  <sprite name=\"glyphs-transparent_1\">  <sprite name=\"glyphs-transparent_2\">";
        public static String Content2 = "\n<sprite name=\"glyphs-transparent_3\">  <sprite name=\"glyphs-transparent_20\">  <sprite name=\"glyphs-transparent_34\">";
        public static String Content3 = "\n<sprite name=\"glyphs-transparent_27\">  <sprite name=\"glyphs-transparent_9\">  <sprite name=\"glyphs-transparent_30\">";
        public static String Content4 = "\n<sprite name=\"glyphs-transparent_34\">  <sprite name=\"glyphs-transparent_9\">  <sprite name=\"glyphs-transparent_30\">";

        
        private static string content = "-These people were all practicing vegetarians.\n" +
        "-They believed in non-violence towards all living beings.\n" +
        "-They worshipped 2 gods.\n" +
        "- <sprite name=\"glyphs-transparent_1\"> - is one of them\n" +
        "- <sprite name=\"glyphs-transparent_2\"> - is the other one\n" +
        "-Their language is fully symbolic.\n" +
        "-Each symbol caries a specific meaning and they are combined to make sentences.\n" +
        "-The symbols that already have concrete meanings are:\n" +
        "- <sprite name=\"glyphs-transparent_3\"> means The people\n" +
        "- <sprite name=\"glyphs-transparent_28\"> means kind\n" +
        "- <sprite name=\"glyphs-transparent_33\"> means life\n" +
        "- <sprite name=\"glyphs-transparent_34\"> means death\n\n" +
        "-These people were well educated but also believed in gods and spirituality.\n";
        [Space] [SerializeField] private TextMeshProUGUI leftSide;
    [SerializeField] private TextMeshProUGUI rightSide;
    //[Space] [SerializeField] private TMP_Text leftPagination;
    //[SerializeField] private TMP_Text rightPagination;


    void Update()
    {
        SetupContent();
    }

    public static void JournalUpdate(int pillar)
    {
        switch (pillar)
        {
            case 1:
                content += Content1;
                break;
            case 2:
                content += Content2;
                break;
            case 3:
                content += Content3;
                break;
            case 4:
                content += Content4;
                break;
            default:
                Debug.Log("Invalid pillar number");
                break;
        }
        
    }
       

        private void OnValidate()
        {
            //UpdatePagination();

            if (leftSide.text == content)
                return;

            SetupContent();
        }

        private void Awake()
        {
            SetupContent();
            //UpdatePagination();
        }

        private void SetupContent()
        {
            leftSide.text = content;
            rightSide.text = content;
        }

        /*private void UpdatePagination()
        {
            leftPagination.text = leftSide.pageToDisplay.ToString();
            rightPagination.text = rightSide.pageToDisplay.ToString();
        }*/

        public void PreviousPage()
        {
            if (leftSide.pageToDisplay < 1)
            {
                leftSide.pageToDisplay = 1;
                return;
            }

            if (leftSide.pageToDisplay - 2 > 1)
                leftSide.pageToDisplay -= 2;
            else
                leftSide.pageToDisplay = 1;

            rightSide.pageToDisplay = leftSide.pageToDisplay + 1;

            //UpdatePagination();
        }

        public void NextPage()
        {
            if (rightSide.pageToDisplay >= rightSide.textInfo.pageCount)
                return;

            if (leftSide.pageToDisplay >= leftSide.textInfo.pageCount - 1)
            {
                leftSide.pageToDisplay = leftSide.textInfo.pageCount - 1;
                rightSide.pageToDisplay = leftSide.pageToDisplay + 1;
            }
            else
            {
                leftSide.pageToDisplay += 2;
                rightSide.pageToDisplay = leftSide.pageToDisplay + 1;
            }

            //UpdatePagination();
        }
    }
