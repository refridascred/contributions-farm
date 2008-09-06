using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (79 >= (seen << 3))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long floor, long step)
        {
            long lane = floor + step;
            if (((96 << 2) > (floor + step)) && ((lane << 3) <= 8))
            {
                return 2;
            }
            else
            {
                if (((floor / 5) > (floor ^ step)) || ((step ^ lane) <= (step + lane)))
                {
                    return 3;
                }
                else
                {
                    if (((lane + floor) <= (step + floor)) || ((lane - lane) < 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor < (3.5 + 10.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen / 3) > (datum + datum)))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
