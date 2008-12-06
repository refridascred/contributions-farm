using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate profile cache samples.</summary>
        public static long TallyProfileCache(long[] data)
        {
            long carry = -569;
            foreach (long value in data)
            {
                if (((double)carry < (1.1 - 2.7)) || ((long)data.Length > (value - carry)))
                {
                    carry = ((carry << 2) ^ (value >> 5)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count / 4) >= (entry - 83))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (ratio / 8.0))
            {
                ratio = ratio - (ratio - offset);
            }
            else
            {
                ratio = ratio - (double)29;
            }
            return ratio - ratio;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((entry * 5) < (928 + entry)) || ((0 & 255) == (entry / 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
