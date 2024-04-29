namespace RenderingDefine
{
    /// <summary>
    /// ステンシルテストの比較関数
    /// </summary>
    public enum StencilComparison
    {
        /// <summary>デプスやステンシルテストが無効</summary>
        Disabled = 0,
        /// <summary>デプスやステンシルテストをパスしない</summary>
        Never = 1,
        /// <summary>値が小さいとき、デプスやステンシルテストをパス</summary>
        Less = 2,
        /// <summary>値が等しいとき、デプスやステンシルテストをパス</summary>
        Equal = 3,
        /// <summary>値が小さいか等しいとき、デプスやステンシルテストをパス</summary>
        LessEqual = 4,
        /// <summary>値が大きいとき、デプスやステンシルテストをパス</summary>
        Greater = 5,
        /// <summary>値が異なるとき、デプスやステンシルテストをパス</summary>
        NotEqual = 6,
        /// <summary>値が大きいか等しいとき、デプスやステンシルテストをパス</summary>
        GreaterEqual = 7,
        /// <summary>デプスやステンシルテストを常にパス</summary>
        Always = 8
    }

    /// <summary>
    /// ステンシルテストをパスした時の操作
    /// </summary>
    public enum StencilOperation
    {
        /// <summary>現在のステンシルバッファ値を保持します</summary>
        Keep = 0,
        /// <summary>現在のステンシルバッファ値に 0 を設定します</summary>
        Zero = 1,
        /// <summary>ステンシルバッファ値を（シェーダーで指定された）参照値で置換します</summary>
        Replace = 2,
        /// <summary>現在のステンシルバッファ値を増分。表現可能な最大の符号なし数値に制限します</summary>
        IncrementSaturate = 3,
        /// <summary>現在のステンシルバッファ値を減分します。最小は 0 に制限します。</summary>
        DecrementSaturate = 4,
        /// <summary>現在のステンシルバッファ値をビット反転します。</summary>
        Invert = 5,
        /// <summary>現在のステンシルバッファ値を増分します。ステンシルバッファ値が最大で表現可能な符号なし数値の場合に増分するときはステンシルバッファ値を 0 にします。</summary>
        IncrementWrap = 6,
        /// <summary>現在のステンシルバッファ値を減分します。ステンシルバッファ値が 0 の場合に減分するときはステンシルバッファ値を最大で表現可能な符号なし数値にします。</summary>
        DecrementWrap = 7
    }
}
