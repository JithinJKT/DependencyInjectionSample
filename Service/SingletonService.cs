namespace DependencyInjectionSample.Service
{
    public class SingletonService : ISingletonService
    {
        private readonly Guid m_strGuid;
        public SingletonService()
        {
            m_strGuid = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return m_strGuid.ToString();
        }
    }
}
