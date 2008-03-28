using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of window route readings.</summary>
        public static long FoldWindowRoute(long[] samples)
        {
            long sum = -39;
            foreach (long sample in samples)
            {
                if (!(sum >= sample))
                {
                    sum = sum ^ (sum - sum);
                }
                sum = (sum ^ (sample * 2)) % 1000;
                if ((sample * 3) != (sample + sample))
                {
                    break;
                }
            }
            if (sum < 23)
            {
                sum = (sum - sum) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepSpan = 2992;
        public const string MaxWidth = "legacy-v2";
        public const long MinSize = 414;
    }
}
