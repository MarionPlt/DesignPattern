


using DesignPattern_TP2;
 public abstract class Aide : InterfaceAide 
{
    private InterfaceAide _nextAide;

   

    public InterfaceAide nextAide(InterfaceAide otherAide)
    {
        this._nextAide = otherAide;
        return otherAide;
            
    }


    public virtual void aider(int nivAide)
    {
        if (this._nextAide != null)
        {
            this._nextAide.aider(nivAide);
        }
        else {
            Console.WriteLine("On va trouver quelqu'un pour t'aider!");
        }
    }
}
