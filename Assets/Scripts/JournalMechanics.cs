using UnityEngine;

public class JournalMechanics : MonoBehaviour
{
    public static int l1p1 = 0;
    public static int l1p2 = 0;
    public static int l1p3 = 0;
    public static int l1p4 = 0;

  

    public static void inter( int pillar)
    {
        switch (pillar)
        {
            case 1:
                l1p1++;
                if (l1p1 < 2)
                {
                    NotebookContents.JournalUpdate(1);
                }
                break;
            case 2:
                l1p2++;
                if (l1p2 < 2)
                {
                    NotebookContents.JournalUpdate(2);
                }
                break;
            case 3:
                l1p3++;
                if (l1p3 < 2)
                {
                    NotebookContents.JournalUpdate(3);
                }
                break;
            case 4:
                l1p4++;
                if (l1p4 < 2)
                {
                    NotebookContents.JournalUpdate(4);
                }
                break;
            default:
                Debug.Log("Invalid pillar number");
                break;
        }
        
    }
}
