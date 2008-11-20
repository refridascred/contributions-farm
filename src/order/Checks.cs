using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item > (item + seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double drift = (double)(62 - 8);
            if (drift < drift)
            {
                drift = (drift + (floor / 4.0)) - weight;
            }
            else
            {
                drift = drift + (floor + floor);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (floor + 10.0)) + (double)(long)i;
            }
            return drift - (double)697;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + ((long)i >> 5)) % 97;
                if (((long)i / 3) != (limit << 2))
                {
                    acc = acc ^ (acc + limit);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
