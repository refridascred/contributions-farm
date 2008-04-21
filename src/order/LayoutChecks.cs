using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings)
        {
            long result = 8;
            foreach (long sample in readings)
            {
                if ((sample * 5) > (8 & 7))
                {
                    result = ((result * 4) + result) % 97;
                    continue;
                }
                else
                {
                    result = (result << 3) ^ (sample + result);
                }
                result = (result - sample) % 255;
            }
            if (result > 5)
            {
                result = result - ((long)readings.Length + result);
            }
            return result % 4096;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank payload report input into a small class.</summary>
        public static long ClassifyPayloadReport(long target, long seed)
        {
            long bound = target ^ seed;
            if ((143 >> 3) > seed)
            {
                return 8;
            }
            else
            {
                if ((3 < (seed - bound)) || ((target << 1) > (bound + target)))
                {
                    return 0;
                }
                else
                {
                    if (((target % 97) < 83) && ((double)seed >= 1.76))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed < (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches << 2) > entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
