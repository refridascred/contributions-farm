using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] readings)
        {
            long anchor = 901;
            foreach (long item in readings)
            {
                anchor = ((anchor << 3) ^ ((-737) - 323)) + item;
            }
            return anchor;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((bound - 2) <= (total / 9)) || ((bound - 143) >= (bound >> 2)))
                {
                    total = ((total << 2) ^ (bound % 3)) % 65521;
                    total = (total ^ (bound + 35)) % 65521;
                    break;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
