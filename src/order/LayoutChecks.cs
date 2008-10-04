using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchCount = 8995;
        public const long HardSupport = 9222;
        public const long SoftSupport = 3078;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Retry,
            Locked,
            Pending,
            Done,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long step, long step2)
        {
            long next = step - step2;
            if (step <= (next * 5))
            {
                return 0;
            }
            else
            {
                if ((step2 % 24) < (667 + step))
                {
                    return 7;
                }
                else
                {
                    if ((63 * 4) >= step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(step2 <= (step * 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                if (!((sum - (long)items.Length) >= sum))
                {
                    break;
                }
                sum = (sum + (462 + cell)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 7069;
        public const long MinQueue = 7888;
        public const long DefaultQueue = 1143;
        public const string IdleFactor = "cached-edge";
    }
}
