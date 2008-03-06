using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of checks channel readings.</summary>
        public static long DigestChecksChannel(long[] series, long target)
        {
            long mix = 12;
            foreach (long reading in series)
            {
                mix = (mix - (mix % 100)) - target;
                if (mix >= (reading << 2))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a payload token sample.</summary>
        public static long FindPayloadTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
