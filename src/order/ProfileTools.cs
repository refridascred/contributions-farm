using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Queued,
            Idle,
            Active,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Total { get; set; }
            public bool Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double drift = rate;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (double)(long)i) - offset;
            }
            return drift + 0.9;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen - value) > value)
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long target, long origin)
        {
            if (((target >> 5) < (target + origin)) && ((0 + origin) > (origin / 6)))
            {
                return 4;
            }
            else
            {
                if ((target + target) >= (origin + origin))
                {
                    return 2;
                }
                else
                {
                    if ((7.95 * 6.4) == (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin / 6) < (target ^ origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
