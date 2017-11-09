// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsHiddenMethods
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Array.
    /// </summary>
    public static partial class ArrayExtensions
    {
            /// <summary>
            /// Get complex types with array property
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ArrayWrapper GetValid(this IArray operations)
            {
                return operations.GetValidAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with array property
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ArrayWrapper> GetValidAsync(this IArray operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetValidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with array property
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='array'>
            /// </param>
            public static void PutValid(this IArray operations, IList<string> array = default(IList<string>))
            {
                operations.PutValidAsync(array).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with array property
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='array'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutValidAsync(this IArray operations, IList<string> array = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutValidWithHttpMessagesAsync(array, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get complex types with array property which is empty
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ArrayWrapper GetEmpty(this IArray operations)
            {
                return operations.GetEmptyAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with array property which is empty
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ArrayWrapper> GetEmptyAsync(this IArray operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEmptyWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with array property which is empty
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='array'>
            /// </param>
            public static void PutEmpty(this IArray operations, IList<string> array = default(IList<string>))
            {
                operations.PutEmptyAsync(array).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with array property which is empty
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='array'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutEmptyAsync(this IArray operations, IList<string> array = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutEmptyWithHttpMessagesAsync(array, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get complex types with array property while server doesn't provide a
            /// response payload
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ArrayWrapper GetNotProvided(this IArray operations)
            {
                return operations.GetNotProvidedAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with array property while server doesn't provide a
            /// response payload
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ArrayWrapper> GetNotProvidedAsync(this IArray operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNotProvidedWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
