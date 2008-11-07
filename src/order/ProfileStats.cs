using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((5.0 + 0.8) != (double)target)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Grade a payload stream value against two limits.</summary>
        public static long SortPayloadStream(long target, long floor)
        {
            if ((target - floor) > (floor >> 5))
            {
                return 5;
            }
            else
            {
                if ((17.0 * 9.4) < (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((14.0 + 4.0) < (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor % 97) == (target / 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] items)
        {
            long anchor = 9;
            foreach (long cell in items)
            {
                if ((cell & 127) <= 7)
                {
                    anchor = ((anchor << 3) ^ (cell + anchor)) % 97;
                }
                if ((double)anchor > (6.19 + 4.0))
                {
                    anchor = (anchor + (anchor >> 4)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor / 9)) % 255;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor - (anchor - anchor)) % 1000;
            }
            return anchor;
        }
    }
}
