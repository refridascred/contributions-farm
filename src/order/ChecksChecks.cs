using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long origin, long target)
        {
            long bound = origin - target;
            if ((target << 1) < target)
            {
                return 2;
            }
            else
            {
                if ((bound <= (origin % 60)) || ((target / 8) <= (origin % 97)))
                {
                    return 4;
                }
                else
                {
                    if (!((16.0 - 6.6) != (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound >> 3) < 9)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
