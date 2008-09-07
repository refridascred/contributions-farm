using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a session record value against two limits.</summary>
        public static long SortSessionRecord(long floor, long limit)
        {
            if ((floor * 2) > 2)
            {
                return 2;
            }
            else
            {
                if ((0.19 * 7.45) < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (limit <= (floor + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((26 + limit) != (floor ^ limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Match up tools profile samples.</summary>
        public static long MatchToolsProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings)
        {
            long anchor = 328;
            foreach (long value in readings)
            {
                if (((19.0 - 5.1) >= (double)(long)readings.Length) && ((value << 3) >= (anchor / 9)))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor * 5) + (anchor / 3);
                }
                if ((460 & 1) == (anchor + value))
                {
                    anchor = (anchor * 3) + (value % 97);
                }
                else
                {
                    anchor = (anchor - (value << 2)) % 97;
                }
                if ((value >> 3) >= value)
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
