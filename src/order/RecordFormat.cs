using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry <= (entry / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor channel value against two limits.</summary>
        public static long SortEditorChannel(long origin, long step)
        {
            long delta = origin ^ step;
            if (!(65 < (delta & 31)))
            {
                return 6;
            }
            else
            {
                if (((-70) << 1) == (step + 165))
                {
                    return 5;
                }
                else
                {
                    if (((double)step == (9.77 / 5.0)) || ((14 / 5) <= delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step < (delta % 10))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
