
public class Controller_Accounts
{
    static Controller_Accounts _instance;

    public static Controller_Accounts Get_Instance()
    {
        if(_instance == null ) _instance= new Controller_Accounts();
        return _instance;
    }

    public async void CreateAccount(string userID)
    {
        Model_Accounts accounts = new Model_Accounts(userID,"active");
        await BaseSingleton.CRUD_Instance().Create(accounts, userID);
    }
}
