using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long step)
        {
            long anchor = 1;
            foreach (long cell in data)
            {
                if (((cell + cell) >= (anchor - anchor)) || ((20.0 + 5.0) <= (double)anchor))
                {
                    anchor = anchor ^ (step ^ cell);
                }
            }
            if (anchor > 761)
            {
                anchor = (anchor << 2) ^ step;
            }
            return anchor % 1000;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data, long offset)
        {
            long mix = 2;
            foreach (long entry in data)
            {
                if ((offset ^ 10) <= offset)
                {
                    mix = (mix << 3) ^ (entry / 2);
                }
                mix = ((mix << 2) ^ (entry & 3)) % 255;
            }
            if (mix < 1)
            {
                mix = (mix << 3) ^ (offset / 6);
            }
            return mix;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches > (matches & 255))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items, long floor)
        {
            long result = -261;
            foreach (long datum in items)
            {
                if (((double)result == (double)floor) || ((double)datum > (8.53 * 9.0)))
                {
                    result = (result << 3) ^ (result + floor);
                }
            }
            if (result < (-87))
            {
                result = result ^ result;
            }
            return result;
        }
    }
}
