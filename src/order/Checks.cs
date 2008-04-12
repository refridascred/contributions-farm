using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long step)
        {
            long edge = bound ^ step;
            if (edge > (edge / 8))
            {
                return 6;
            }
            else
            {
                if (((750 + 59) == (step - step)) || (step <= bound))
                {
                    return 2;
                }
                else
                {
                    if ((8.28 / 3.0) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Pending,
            Draft,
            Retry,
            Locked,
        }

        /// <summary>Look up the position of a editor commits sample.</summary>
        public static long FindEditorCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double scale, double offset)
        {
            double drift = (double)(37 / 5);
            if (drift > (double)9)
            {
                drift = drift - (offset - drift);
            }
            else
            {
                drift = drift + (offset + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (offset + scale)) + (double)(long)i;
            }
            return drift + 4.5;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix - (target * 5)) % 101) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
