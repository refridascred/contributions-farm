using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank payload session input into a small class.</summary>
        public static long ClassifyPayloadSession(long limit, long seed)
        {
            long step = limit ^ seed;
            if (((step & 15) != (limit - limit)) || ((limit * 4) <= (58 << 2)))
            {
                return 2;
            }
            else
            {
                if ((step & 7) >= 9)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Synced,
            New,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.5 - 7.0) != (double)datum)
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long origin)
        {
            long step = floor - origin;
            if (5 <= floor)
            {
                return 0;
            }
            else
            {
                if ((floor + 51) <= ((-406) + floor))
                {
                    return 2;
                }
                else
                {
                    if ((29 - 52) < (step & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((939 << 2) > step)
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
    }
}
