using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate tools stats samples.</summary>
        public static long FoldToolsStats(long[] readings, long offset)
        {
            long mix = 1;
            foreach (long datum in readings)
            {
                mix = ((mix + (mix + datum)) % 101) + offset;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] series)
        {
            long anchor = 3;
            foreach (long sample in series)
            {
                if (anchor > (sample % 2))
                {
                    anchor = anchor - ((long)series.Length & 7);
                }
                if ((sample * 4) <= sample)
                {
                    anchor = (anchor - (sample >> 3)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] samples, long floor)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                anchor = (anchor - (floor + anchor)) ^ cell;
                anchor = ((anchor << 2) ^ (anchor % 64)) % 101;
            }
            if (anchor > 2)
            {
                anchor = (anchor + (floor >> 4)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Count context report pairs that satisfy a relation.</summary>
        public static long OverlapContextReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
