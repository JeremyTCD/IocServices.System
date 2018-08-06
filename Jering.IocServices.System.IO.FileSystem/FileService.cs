using System.IO;
using System;
using System.Text;
using System.Collections.Generic;

namespace Jering.IocServices.System.IO
{
    public class FileService : IFileService
    {
        public StreamReader OpenText(String path)
        {
            return File.OpenText(path);
        }

        public StreamWriter CreateText(String path)
        {
            return File.CreateText(path);
        }

        public StreamWriter AppendText(String path)
        {
            return File.AppendText(path);
        }

        public void Copy(String sourceFileName, String destFileName)
        {
            File.Copy(sourceFileName, destFileName);
        }

        public void Copy(String sourceFileName, String destFileName, Boolean overwrite)
        {
            File.Copy(sourceFileName, destFileName, overwrite);
        }

        public FileStream Create(String path)
        {
            return File.Create(path);
        }

        public FileStream Create(String path, Int32 bufferSize)
        {
            return File.Create(path, bufferSize);
        }

        public FileStream Create(String path, Int32 bufferSize, FileOptions options)
        {
            return File.Create(path, bufferSize, options);
        }

        public void Delete(String path)
        {
            File.Delete(path);
        }

        public Boolean Exists(String path)
        {
            return File.Exists(path);
        }

        public FileStream Open(String path, FileMode mode)
        {
            return File.Open(path, mode);
        }

        public FileStream Open(String path, FileMode mode, FileAccess access)
        {
            return File.Open(path, mode, access);
        }

        public FileStream Open(String path, FileMode mode, FileAccess access, FileShare share)
        {
            return File.Open(path, mode, access, share);
        }

        public void SetCreationTime(String path, DateTime creationTimeUtc)
        {
            File.SetCreationTime(path, creationTimeUtc);
        }

        public void SetCreationTimeUtc(String path, DateTime creationTime)
        {
            File.SetCreationTimeUtc(path, creationTime);
        }

        public DateTime GetCreationTime(String path)
        {
            return File.GetCreationTime(path);
        }

        public DateTime GetCreationTimeUtc(String path)
        {
            return File.GetCreationTimeUtc(path);
        }

        public void SetLastAccessTime(String path, DateTime lastAccessTime)
        {
            File.SetLastAccessTime(path, lastAccessTime);
        }

        public void SetLastAccessTimeUtc(String path, DateTime lastAccessTimeUtc)
        {
            File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        }

        public DateTime GetLastAccessTime(String path)
        {
            return File.GetLastAccessTime(path);
        }

        public DateTime GetLastAccessTimeUtc(String path)
        {
            return File.GetLastAccessTimeUtc(path);
        }

        public void SetLastWriteTime(String path, DateTime lastWriteTime)
        {
            File.SetLastWriteTime(path, lastWriteTime);
        }

        public void SetLastWriteTimeUtc(String path, DateTime lastWriteTimeUtc)
        {
            File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        }

        public DateTime GetLastWriteTime(String path)
        {
            return File.GetLastWriteTime(path);
        }

        public DateTime GetLastWriteTimeUtc(String path)
        {
            return File.GetLastWriteTimeUtc(path);
        }

        public FileAttributes GetAttributes(String path)
        {
            return File.GetAttributes(path);
        }

        public void SetAttributes(String path, FileAttributes fileAttributes)
        {
            File.SetAttributes(path, fileAttributes);
        }

        public FileStream OpenRead(String path)
        {
            return File.OpenRead(path);
        }

        public FileStream OpenWrite(String path)
        {
            return File.OpenWrite(path);
        }

        public String ReadAllText(String path)
        {
            return File.ReadAllText(path);
        }

        public String ReadAllText(String path, Encoding encoding)
        {
            return File.ReadAllText(path, encoding);
        }

        public void WriteAllText(String path, String contents)
        {
            File.WriteAllText(path, contents);
        }

        public void WriteAllText(String path, String contents, Encoding encoding)
        {
            File.WriteAllText(path, contents, encoding);
        }

        public Byte[] ReadAllBytes(String path)
        {
            return File.ReadAllBytes(path);
        }

        public void WriteAllBytes(String path, Byte[] bytes)
        {
            File.WriteAllBytes(path, bytes);
        }

        public String[] ReadAllLines(String path)
        {
            return File.ReadAllLines(path);
        }

        public String[] ReadAllLines(String path, Encoding encoding)
        {
            return File.ReadAllLines(path, encoding);
        }

        public IEnumerable<String> ReadLines(String path)
        {
            return File.ReadLines(path);
        }

        public IEnumerable<String> ReadLines(String path, Encoding encoding)
        {
            return File.ReadLines(path, encoding);
        }

        public void WriteAllLines(String path, IEnumerable<String> contents)
        {
            File.WriteAllLines(path, contents);
        }

        public void WriteAllLines(String path, IEnumerable<String> contents, Encoding encoding)
        {
            File.WriteAllLines(path, contents, encoding);
        }

        public void AppendAllText(String path, String contents)
        {
            File.AppendAllText(path, contents);
        }

        public void AppendAllText(String path, String contents, Encoding encoding)
        {
            File.AppendAllText(path, contents, encoding);
        }

        public void AppendAllLines(String path, IEnumerable<String> contents)
        {
            File.AppendAllLines(path, contents);
        }

        public void AppendAllLines(String path, IEnumerable<String> contents, Encoding encoding)
        {
            File.AppendAllLines(path, contents, encoding);
        }

        public void Move(String sourceFileName, String destFileName)
        {
            File.Move(sourceFileName, destFileName);
        }
    }
}