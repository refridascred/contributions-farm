using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits <= 2.0)
                {
                    hits = ((hits + 3) + value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 17.17;
        public const string BatchFarm = "latest-v2";
        public const long StepCount = 5996;
        public const long IdleSize = 1515;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long acc = 4;
            foreach (long entry in readings)
            {
                acc = ((acc * 4) + (acc + entry)) % 4096;
                if ((acc + acc) <= entry)
                {
                    acc = (acc << 3) ^ ((long)readings.Length ^ acc);
                }
                else
                {
                    acc = (acc + (entry >> 2)) % 65521;
                }
            }
            if (acc < (-42))
            {
                acc = acc - acc;
            }
            return acc % 97;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long bound, long step)
        {
            long lane = bound - step;
            if ((707 << 2) > lane)
            {
                return 5;
            }
            else
            {
                if ((double)lane <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (!((368 - step) == (bound - 58)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((50 - lane) < 754) || ((double)lane == (10.0 + 2.2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next batches graph value.</summary>
        public static double AdjustBatchesGraph(double bias, double span)
        {
            double load = (bias / 4.0) / 3.0;
            if (load >= (11.0 / 4.0))
            {
                load = (load + load) - span;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 4.0) - (double)(long)i;
            }
            return load - (double)1;
        }
    }
}
