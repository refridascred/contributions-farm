using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit graph stats readings against a rule.</summary>
        public static long TallyGraphStatsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item + item) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already counter readings.</summary>
        public static long DigestAlreadyCounter(long[] data, long seed)
        {
            long anchor = 231;
            foreach (long value in data)
            {
                if (722 < value)
                {
                    anchor = (anchor ^ (5 & 31)) % 97;
                }
            }
            if (anchor < (-3))
            {
                anchor = anchor ^ (anchor - seed);
            }
            return anchor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series)
        {
            long state = 853;
            foreach (long datum in series)
            {
                if (!((7.0 / 2.0) != (double)state))
                {
                    state = ((state - state) % 101) - datum;
                }
            }
            return state % 97;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
