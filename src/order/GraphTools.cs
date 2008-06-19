using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter cluster readings against a rule.</summary>
        public static long TallyCounterClusterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((double)seen >= (double)20) || ((entry - (long)samples.Length) > (seen ^ 132)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a schema buffer value against two limits.</summary>
        public static long RankSchemaBuffer(long limit, long floor)
        {
            if ((limit >> 3) == (74 ^ floor))
            {
                return 3;
            }
            else
            {
                if (90 <= floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)floor < (2.34 * 3.8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor <= (0.8 - 7.07))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "open-edge";
        public const long CacheFarm = 6885;
        public const string MaxScore = "cached-1";
        public const long StepTimeout = 6088;
        public const double BatchFarm = 87.29;
    }
}
