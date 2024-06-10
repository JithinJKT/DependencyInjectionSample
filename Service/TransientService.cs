namespace DependencyInjectionSample.Service
{
    public class TransientService : ITransientService
    {
        private readonly Guid m_strGuid;
        public TransientService()
        {
            m_strGuid = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return m_strGuid.ToString();
        }
    }
}
