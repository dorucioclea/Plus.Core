using Plus.DependencyInjection;
using System.Threading;

namespace Plus.MultiTenancy
{
    public class AsyncLocalCurrentTenantAccessor : ICurrentTenantAccessor, ISingletonDependency
    {
        public BasicTenantInfo Current
        {
            get => _currentScope.Value;
            set => _currentScope.Value = value;
        }

        private readonly AsyncLocal<BasicTenantInfo> _currentScope;

        public AsyncLocalCurrentTenantAccessor()
        {
            _currentScope = new AsyncLocal<BasicTenantInfo>();
        }
    }
}