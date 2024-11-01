using Base.Services;

/// <summary>
/// 加解密
/// 語法 KeyCmd [action] [key] [data]
/// action 傳入參數
///   -e encode 加密
///   -d decode 解密
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        //args = ["-e", "11" ,"123"];
        Console.WriteLine($"args.Length={args.Length}");

        //檢查傳入參數
        if (args.Length != 3)
            goto labError;

        //action
        var act = args[0].ToUpper();
        Console.WriteLine($"act={act}");
        bool? isEncode = (act == "-E") ? true :
            (act == "-D") ? false : null;
        if (isEncode == null)
            goto labError;

        //encode/decode
        var isEncode2 = (bool)isEncode;
        var result = _Str.EncodeDecodeByKey(isEncode2, args[2], args[1]);
        Console.WriteLine($"加解密結果: {result}");
        if (isEncode2)
            Console.WriteLine($"還原結果(驗證用途): {_Str.EncodeDecodeByKey(!isEncode2, result, args[1])}");
        return;

    labError:
        Console.WriteLine("語法: KeyCmd -e(encode)/-d(decode) key data");
    }
}

