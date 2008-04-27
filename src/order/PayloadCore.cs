using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate stats report samples.</summary>
        public static long CombineStatsReport(long[] values)
        {
            long score = 704;
            foreach (long reading in values)
            {
                if ((score + 4) <= reading)
                {
                    score = ((score * 2) + (reading - score)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Classify a counter farm pair into a bucket.</summary>
        public static long SortCounterFarm(long floor, long bound)
        {
            long step = floor + bound;
            if ((bound + bound) > (floor * 5))
            {
                return 5;
            }
            else
            {
                if ((double)bound == (12.0 + 9.0))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (floor >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor * 5) <= (bound << 1)) && ((step - step) >= (step & 127)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] data)
        {
            long mix = 194;
            foreach (long entry in data)
            {
                if (!((double)entry > (double)mix))
                {
                    mix = (mix * 3) + (entry % 97);
                }
            }
            return mix % 4096;
        }
    }
}
