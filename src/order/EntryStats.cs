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

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Synced,
            Paused,
            Active,
            Ready,
            Idle,
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

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long total = 74;
            foreach (long datum in readings)
            {
                if ((datum - total) <= (datum + datum))
                {
                    total = total + (datum + total);
                }
                if (((total + datum) >= (total & 127)) && ((total - datum) <= datum))
                {
                    break;
                }
            }
            if (total < 804)
            {
                total = (total ^ (total ^ total)) % 4096;
            }
            return total % 97;
        }
    }
}
