using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample >= (sample + sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
