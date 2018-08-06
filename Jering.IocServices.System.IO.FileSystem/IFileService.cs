using System.IO;
using System;
using System.Text;
using System.Collections.Generic;

namespace Jering.IocServices.System.IO
{
    public interface IFileService
    {
        StreamReader OpenText(String path);
        StreamWriter CreateText(String path);
        StreamWriter AppendText(String path);
        void Copy(String sourceFileName, String destFileName);
        void Copy(String sourceFileName, String destFileName, Boolean overwrite);
        FileStream Create(String path);
        FileStream Create(String path, Int32 bufferSize);
        FileStream Create(String path, Int32 bufferSize, FileOptions options);
        void Delete(String path);
        Boolean Exists(String path);
        FileStream Open(String path, FileMode mode);
        FileStream Open(String path, FileMode mode, FileAccess access);
        FileStream Open(String path, FileMode mode, FileAccess access, FileShare share);
        void SetCreationTime(String path, DateTime creationTimeUtc);
        void SetCreationTimeUtc(String path, DateTime creationTime);
        DateTime GetCreationTime(String path);
        DateTime GetCreationTimeUtc(String path);
        void SetLastAccessTime(String path, DateTime lastAccessTime);
        void SetLastAccessTimeUtc(String path, DateTime lastAccessTimeUtc);
        DateTime GetLastAccessTime(String path);
        DateTime GetLastAccessTimeUtc(String path);
        void SetLastWriteTime(String path, DateTime lastWriteTime);
        void SetLastWriteTimeUtc(String path, DateTime lastWriteTimeUtc);
        DateTime GetLastWriteTime(String path);
        DateTime GetLastWriteTimeUtc(String path);
        FileAttributes GetAttributes(String path);
        void SetAttributes(String path, FileAttributes fileAttributes);
        FileStream OpenRead(String path);
        FileStream OpenWrite(String path);
        String ReadAllText(String path);
        String ReadAllText(String path, Encoding encoding);
        void WriteAllText(String path, String contents);
        void WriteAllText(String path, String contents, Encoding encoding);
        Byte[] ReadAllBytes(String path);
        void WriteAllBytes(String path, Byte[] bytes);
        String[] ReadAllLines(String path);
        String[] ReadAllLines(String path, Encoding encoding);
        IEnumerable<String> ReadLines(String path);
        IEnumerable<String> ReadLines(String path, Encoding encoding);
        void WriteAllLines(String path, IEnumerable<String> contents);
        void WriteAllLines(String path, IEnumerable<String> contents, Encoding encoding);
        void AppendAllText(String path, String contents);
        void AppendAllText(String path, String contents, Encoding encoding);
        void AppendAllLines(String path, IEnumerable<String> contents);
        void AppendAllLines(String path, IEnumerable<String> contents, Encoding encoding);
        void Move(String sourceFileName, String destFileName);
    }
}