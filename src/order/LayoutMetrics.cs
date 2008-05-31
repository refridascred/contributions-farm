using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long bound2)
        {
            if ((bound2 - 347) <= bound2)
            {
                return 1;
            }
            else
            {
                if ((bound ^ bound2) <= bound2)
                {
                    return 6;
                }
                else
                {
                    if ((bound2 >> 2) < (bound2 - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)21 == (double)bound2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Retry,
            Draft,
            Ready,
        }
    }
}
