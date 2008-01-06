using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            New,
            Queued,
            Done,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long origin, long floor)
        {
            long offset = origin + floor;
            if (offset < (floor / 3))
            {
                return 4;
            }
            else
            {
                if ((floor * 3) < origin)
                {
                    return 5;
                }
                else
                {
                    if (!((offset / 6) > floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((0 ^ total) > (floor + 67))
                {
                    total = ((total * 3) + floor) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ total) % 4096;
                }
                if ((floor % 16) < (floor << 2))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Draft,
            Retry,
            Pending,
        }
    }
}
