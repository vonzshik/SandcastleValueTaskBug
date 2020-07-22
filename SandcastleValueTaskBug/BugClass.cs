using System;
using System.Threading;
using System.Threading.Tasks;

namespace SandcastleValueTaskBug
{
    /// <summary>
    /// Class with bug method
    /// </summary>
    public class BugClass
    {
        /// <summary>
        /// Bug method
        /// </summary>
        /// <param name="cancellationToken">Token to cancel</param>
        /// <returns>ValueTask from int</returns>
        public ValueTask<int> BugMethod(CancellationToken cancellationToken = default) => new ValueTask<int>(0);

        /// <summary>
        /// Ok method
        /// </summary>
        /// <param name="cancellationToken">Token to cancel</param>
        /// <returns>Task from int</returns>
        public Task<int> OkMethod(CancellationToken cancellationToken = default) => new Task<int>(() => 0);
    }
}
