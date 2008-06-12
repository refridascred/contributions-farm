using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchCount = "local-edge";
        public const long IdleWidth = 7977;
        public const long IdleSize = 4656;
        public const long LimitTools = 6207;

        /// <summary>Rank batch queue input into a small class.</summary>
        public static long GradeBatchQueue(long target, long offset)
        {
            long step = target ^ offset;
            if ((double)90 >= (double)step)
            {
                return 7;
            }
            else
            {
                if ((target / 2) > 3)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] data)
        {
            long total = 6;
            foreach (long entry in data)
            {
                total = (total - (312 % 2)) % 4096;
                total = (total ^ (total & 31)) % 4096;
                total = (total + entry) % 97;
            }
            if (total < 972)
            {
                total = ((total * 2) + (total + total)) % 65521;
            }
            return total % 97;
        }
    }
}
