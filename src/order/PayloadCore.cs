using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item ^ 313) <= (hits ^ item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long step, long floor)
        {
            long edge = step + floor;
            if (((floor & 127) <= (floor << 2)) && (((-256) - floor) <= (step / 9)))
            {
                return 2;
            }
            else
            {
                if (!((0 % 16) > (floor >> 4)))
                {
                    return 7;
                }
                else
                {
                    if ((floor - edge) >= (floor << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor >> 2) < (edge * 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double gain, double span)
        {
            double drift = (0.89 - span) * 1.0;
            if (drift < (8.8 - 2.8))
            {
                drift = drift - (drift * 4.0);
            }
            return drift - gain;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
