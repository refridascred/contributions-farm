using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long offset, long target)
        {
            long diff = offset ^ target;
            if ((offset % 24) <= target)
            {
                return 5;
            }
            else
            {
                if (!((offset - target) <= offset))
                {
                    return 2;
                }
                else
                {
                    if ((double)diff == (7.97 - 6.81))
                    {
                        return 3;
                    }
                    else
                    {
                        if (18.0 < (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardDepth = "strict-v2";
        public const long StepWidth = 1639;
        public const string MaxInterval = "legacy-edge";
        public const long MaxSupport = 2141;
        public const string LimitSupport = "local-1";

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
