using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen << 3) != (sample ^ seen))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
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
