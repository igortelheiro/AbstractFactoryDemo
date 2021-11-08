namespace AbstractFactoryDemo.Services
{
    public interface IBodyShopService
    {
        void ExecuteBodyShopService(BodyShopServiceEnum service, string part);
    }
    
    
    public enum BodyShopServiceEnum
    {
        RecuperacaoDeLataria,
        Polimento
    }
}