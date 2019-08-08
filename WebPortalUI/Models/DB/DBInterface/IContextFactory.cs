namespace WebPortalUI.Models.DB
{
    public interface IContextFactory
    {
        IContext<T> Instance<T>() where T : class, new();
        IUserContext UserContextInstance();
    }
}
