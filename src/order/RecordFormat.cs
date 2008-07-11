using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate metrics filter readings against a bound.</summary>
        public static bool VerifyMetricsFilterRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = (result + (floor - (long)i)) % 1000;
                long seen = 981 - (long)i;
                if (1.4 < (double)seen)
                {
                    seen = (seen ^ (seen - result)) % 1000;
                    break;
                }
                else
                {
                    seen = ((seen << 2) ^ seen) % 65521;
                    seen = (seen * 2) + (result * 5);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Synced,
            Queued,
            Draft,
        }
    }
}
