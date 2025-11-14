using UnityEngine;

public class JournalMechanics : MonoBehaviour
{
    public static int l1p1 = 0;
    public static int l1p2 = 0;
    public static int l1p3 = 0;
    public static int l1p4 = 0;

    public static int L2W1 = 0;
    public static int L2W2 = 0;
    public static int L2W3 = 0;
    public static int L2W4 = 0; 
    public static int L2W5 = 0;

  

    public static void inter(int pillar)
    {
        Debug.Log("Interacted with pillar " + pillar);
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
            
            case 5:
                L2W1++;
                if (L2W1 < 2)
                {
                    NotebookContents.JournalUpdate(5);
                }
                break;

            case 6:
                L2W2++;
                if (L2W2 < 2)
                {
                    NotebookContents.JournalUpdate(6);
                }
                break;

            case 7:
                L2W3++;
                if (L2W3 < 2)
                {
                    NotebookContents.JournalUpdate(7);
                }
                break;
            
            case 8:
                L2W4++;
                if (L2W4 < 2)
                {
                    NotebookContents.JournalUpdate(8);
                }
                break;

            case 9:
                L2W5++;
                if (L2W5 < 2)
                {
                    NotebookContents.JournalUpdate(9);
                }
                break;
                
            default:
                Debug.Log("Invalid pillar number");
                break;
        }
        
    }
}
