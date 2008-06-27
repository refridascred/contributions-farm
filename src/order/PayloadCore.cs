using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels, long step)
        {
            long anchor = -830;
            foreach (long item in levels)
            {
                anchor = ((anchor - (step / 7)) % 101) + item;
            }
            if (anchor > 374)
            {
                anchor = (anchor - (anchor / 7)) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] series)
        {
            long result = 7;
            foreach (long cell in series)
            {
                result = (result << 3) ^ (result + cell);
            }
            if (result > 714)
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
