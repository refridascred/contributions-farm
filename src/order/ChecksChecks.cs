using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long offset, long target)
        {
            long span = offset ^ target;
            if (((target >> 2) != (span % 24)) || ((span + offset) != (target + target)))
            {
                return 3;
            }
            else
            {
                if (((double)span != (double)(-85)) && ((span * 4) <= offset))
                {
                    return 4;
                }
                else
                {
                    if ((587 >> 2) < (target + 430))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((span / 9) <= (span + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryWidth = 845;
        public const string SoftTimeout = "staging-1";
        public const long WindowPayload = 1687;
        public const string IdleTimeout = "cached";
        public const long StepFactor = 6188;

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
