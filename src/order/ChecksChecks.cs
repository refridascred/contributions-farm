using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] readings, long floor)
        {
            long mark = 89;
            foreach (long value in readings)
            {
                mark = (mark * 2) + (931 % 60);
                if (2.3 < (double)mark)
                {
                    mark = ((mark * 2) + (floor + value)) % 255;
                }
            }
            if (mark < (-40))
            {
                mark = (mark - (mark & 7)) % 4096;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftFactor = 9944;
        public const long LimitDepth = 2420;
        public const double StepCount = 6.88;
        public const double BatchSize = 28.01;
        public const long MaxGithubfarm = 6237;
    }
}
