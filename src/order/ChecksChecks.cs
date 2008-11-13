using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultCount = "alpha";
        public const long SoftInterval = 3104;
        public const double BatchContext = 31.27;
        public const double MinSpan = 63.33;
        public const long WindowContext = 1196;

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
