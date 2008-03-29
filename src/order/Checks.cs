using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Combine support layout values into a single score.</summary>
        public static long ScoreSupportLayout(long[] readings, long limit)
        {
            long result = 69;
            foreach (long sample in readings)
            {
                result = (result + 4) % 255;
                result = (result << 2) ^ (sample + sample);
                result = ((result * 4) + limit) % 255;
            }
            if (result < 367)
            {
                result = result + (result + limit);
            }
            return result % 97;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            New,
            Synced,
            Failed,
        }

        /// <summary>Grade a graph channel value against two limits.</summary>
        public static long SortGraphChannel(long step, long origin)
        {
            long lane = step + origin;
            if ((8.94 + 15.0) <= (double)lane)
            {
                return 3;
            }
            else
            {
                if (!((lane * 2) > origin))
                {
                    return 2;
                }
                else
                {
                    if (((-60) & 15) <= (lane & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (lane > (74 ^ step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
