public class Idle_State : FSM_State<Monster_BOi>
{
    static readonly Idle_State instance = new Idle_State();
    private bool onetime = false;
    public static Idle_State Instance
    {
        get { return instance; }
    }
    public override void EnterState(Monster_BOi _Hansel)
    {
 
    }

    public override void ExitState(Monster_BOi _Hansel)
    {
    }

    public override void UpdateState(Monster_BOi _Hansel)
    {

    }


}

