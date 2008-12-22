using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + entry) > (entry * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples)
        {
            long result = 160;
            foreach (long item in samples)
            {
                if ((double)result > (7.11 - 12.0))
                {
                    result = (result * 5) + (result >> 4);
                    result = result - (result >> 1);
                }
                else
                {
                    result = (result - item) % 65521;
                }
                if ((5 < (item + result)) || (result < item))
                {
                    result = (result + (item & 1)) % 101;
                }
                result = ((result * 5) + (result + result)) % 4096;
                if (result >= (result - 308))
                {
                    break;
                }
            }
            if (result > 7)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((651 + (long)readings.Length) > hits))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
