using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum << 2) ^ bound) % 97;
                sum = (sum + (2 + 74)) % 65521;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a tools report value against two limits.</summary>
        public static long RankToolsReport(long step, long seed)
        {
            if ((double)step > (20.0 - 3.3))
            {
                return 5;
            }
            else
            {
                if ((64 ^ 31) < (step & 63))
                {
                    return 7;
                }
                else
                {
                    if (((seed + step) <= (step / 9)) || (seed < (seed + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] readings)
        {
            long score = 33;
            foreach (long datum in readings)
            {
                score = ((score * 2) + (datum << 1)) % 65521;
            }
            return score;
        }
    }
}
