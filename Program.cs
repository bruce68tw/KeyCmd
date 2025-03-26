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

        //get action
        var act = args[0].ToUpper();
        Console.WriteLine($"act={act}");
        bool? isEncode = (act == "-E") ? true :
            (act == "-D") ? false : null;
        if (isEncode == null)
            goto labError;

        //encode/decode
        var key = args[1];
        var isEncode2 = (bool)isEncode;
        var result = isEncode2
            ? _Str.Encode(args[2], key)
            : _Str.Decode(args[2], key);
        Console.WriteLine($"加解密結果: {result}");
        if (isEncode2)
            Console.WriteLine($"還原結果(驗證用途): {_Str.Decode(result, key)}");
        return;

    labError:
        Console.WriteLine("語法: KeyCmd -e(encode)/-d(decode) key data");
    }
}

