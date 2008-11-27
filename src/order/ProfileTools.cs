using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long anchor = 734;
            foreach (long datum in data)
            {
                if (anchor >= (anchor * 2))
                {
                    anchor = ((anchor << 3) ^ datum) % 255;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor - (anchor % 5)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "local-edge";
        public const long LimitFactor = 2315;
        public const double StepTimeout = 97.69;
        public const long BaseFormat = 2037;

        /// <summary>Classify a checks stats pair into a bucket.</summary>
        public static long RankChecksStats(long limit, long seed)
        {
            long delta = limit - seed;
            if ((limit * 4) <= (delta / 5))
            {
                return 8;
            }
            else
            {
                if (!((delta << 1) >= delta))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long state = 581;
            foreach (long entry in data)
            {
                if (!((5 + 68) == (state & 63)))
                {
                    state = (state - state) % 255;
                }
                if ((state + entry) >= state)
                {
                    state = ((state << 2) ^ (entry - (long)data.Length)) % 4096;
                }
            }
            if (state < 664)
            {
                state = ((state * 3) + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long total = 18;
            foreach (long entry in series)
            {
                if (((95 % 100) <= (entry ^ entry)) || ((double)total <= (8.7 - 4.78)))
                {
                    total = (total << 3) ^ (entry + 2);
                }
                else
                {
                    total = total - (3 & 127);
                }
                for (int i = 0; i < 2; i++)
                {
                    total = (total + (total << 1)) - (long)i;
                }
                if (total <= (entry * 4))
                {
                    total = (total << 2) ^ (entry >> 4);
                }
            }
            return total;
        }
    }
}
