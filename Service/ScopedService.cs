namespace DependencyInjectionSample.Service
{
    public class ScopedService : IScopedService
    {
        private readonly Guid m_strGuid;
        public ScopedService()
        {
            m_strGuid =Guid.NewGuid();
        }
        public string GetGuid()
        {
            return m_strGuid.ToString();
        }
    }
}
