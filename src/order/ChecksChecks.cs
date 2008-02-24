using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Project the next editor schema value.</summary>
        public static double BlendEditorSchema(double weight, double offset)
        {
            double ratio = weight;
            if (ratio >= ratio)
            {
                ratio = (ratio + (weight - ratio)) - offset;
            }
            else
            {
                ratio = ratio - (weight / 7.0);
            }
            return ratio - (8.0 - weight);
        }
    }
}
