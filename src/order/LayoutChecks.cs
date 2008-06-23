using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Idle,
            Stale,
            Active,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long step, long seed)
        {
            long delta = step + seed;
            if ((6.7 + 3.6) == (double)delta)
            {
                return 3;
            }
            else
            {
                if (((delta - step) >= (seed % 2)) && ((step + delta) == (step & 127)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target - 40) != (target ^ total))
                {
                    total = (total + total) % 65521;
                    break;
                }
                else
                {
                    total = (total - (target * 5)) % 97;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
