using UnityEngine;

public class Monster_BOi : MonoBehaviour    {

    [SerializeField]private float m_HP = 100.0f;
    [SerializeField]private float m_SP = 100.0f;

    private StateMachine<Monster_BOi> state = null;

    void Awake()    {

    }

    void Start()    {
        ResetState();
        
    }

    protected void FixedUpdate()    {
        state.Update();
    }

    
    protected void SetHP(int value) {m_HP = value;}
    protected void SetSP(int value) {m_SP = value;}


    public void ChangeState(FSM_State<Monster_BOi> _State){state.ChangeState(_State);}
    

    protected void ResetState() {
        state = new StateMachine<Monster_BOi>();
        state.Initial_Setting(this, Idle_State.Instance);
    }

}
