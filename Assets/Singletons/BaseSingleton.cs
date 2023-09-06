public class BaseSingleton
{
    public static Controller_CRUD CRUD_Instance()
    {
        return Controller_CRUD.Get_Instance();
    }

    public static Controller_Accounts Accounts()
    {
        return Controller_Accounts.Get_Instance();
    }

}
