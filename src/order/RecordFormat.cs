using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((300 - target) >= (matches + matches)) && ((matches ^ 8) > (reading - 4)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc + acc) % 101;
                acc = ((acc << 3) ^ acc) % 4096;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc << 3) ^ acc) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of tools format readings.</summary>
        public static long MatchToolsFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a token payload value against two limits.</summary>
        public static long GradeTokenPayload(long floor, long limit)
        {
            long delta = floor - limit;
            if ((delta + delta) > (floor - limit))
            {
                return 0;
            }
            else
            {
                if ((floor & 255) > (-29))
                {
                    return 5;
                }
                else
                {
                    if (((delta * 3) == (limit ^ floor)) || ((floor + floor) < delta))
                    {
                        return 1;
                    }
                    else
                    {
                        if (8.75 <= (double)floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Paused,
            Done,
            Locked,
            Failed,
        }
    }
}
